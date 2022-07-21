#!/usr/bin/env bash
# exit when any command fails
set -e

RHYNOWTENANT="39e2b6a6-1153-4e5a-9489-733e891b9fcf"
DEVSUBSCRIPTION="8a09746f-31d7-4331-bac2-2cf0971d06a3"
LOCATION="westeurope"

FRONTENDRESOURCEGROUP="frontend"
FRONTSTORAGEACCOUNT="devrhynowfront"
FRONTCONTAINER="frontend"

do_login()
{
    subscriptionId="$(az account list --query "[?isDefault].id" -o tsv)"
    if [ $subscriptionId != $DEVSUBSCRIPTION ]; then
        az login --tenant $RHYNOWTENANT
        az account set --subscription $DEVSUBSCRIPTION
    fi
}

do_resource_group()
{
    if [ $(az group exists --name $FRONTENDRESOURCEGROUP) = false ]; then
        az group create --name $FRONTENDRESOURCEGROUP --location $LOCATION
    fi
}

do_storage_account()
{
    az deployment group create \
    --name FrontendStorageAccount \
    --resource-group $FRONTENDRESOURCEGROUP \
    --template-file storage_account.json \
    --parameters storageAccountName=$FRONTSTORAGEACCOUNT containerName=$FRONTCONTAINER location=$LOCATION
}

main()
{
    do_login
    do_resource_group
    do_storage_account
}

# Start
main
# End