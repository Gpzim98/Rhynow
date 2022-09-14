#!/usr/bin/env bash
# exit when any command fails
set -e

RHYNOWTENANT="8c9c375d-cfba-4e19-8574-74b31e067f35"
DEVSUBSCRIPTION="b903fd50-852e-48e8-a549-a50fce419269"
LOCATION="westeurope"

BACKENDRESOURCEGROUP="backend"
STORAGEACCOUNTNAME="devcheckout"
APPNAME="devcheckout"

do_login()
{
    echo "Start Login"
    subscriptionId="$(az account list --query "[?isDefault].id" -o tsv)"
    if [ $subscriptionId != $DEVSUBSCRIPTION ]; then
        az login --tenant $RHYNOWTENANT
        az account set --subscription $DEVSUBSCRIPTION
    fi
    echo "End Login"
}

do_resource_group()
{
    echo "Checking Resource Groups"
    if [ $(az group exists --name $BACKENDRESOURCEGROUP) = false ]; then
        az group create --name $BACKENDRESOURCEGROUP --location $LOCATION
    fi
    echo "End Resource Group"
}

do_function_app()
{
    echo "Start Function App"
    az deployment group create \
    --name CheckoutFunctionApp \
    --resource-group $BACKENDRESOURCEGROUP \
    --template-file azuredeploy.json \
    --parameters appName=$APPNAME storageAccountName=$STORAGEACCOUNTNAME \
    --verbose
    echo "End function App"
}

main()
{
    do_login
    do_resource_group
    do_function_app
}

# Start
main
# End