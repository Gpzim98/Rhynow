#!/usr/bin/env bash
# exit when any command fails
set -e

RHYNOWTENANT="39e2b6a6-1153-4e5a-9489-733e891b9fcf"
DEVSUBSCRIPTION="8a09746f-31d7-4331-bac2-2cf0971d06a3"
LOCATION="westeurope"

BACKENDRESOURCEGROUP="backend"
STORAGEACCOUNTNAME="devcheckoutrhynow"
APPNAME="devcheckoutrhynow"

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