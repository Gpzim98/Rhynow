#!/usr/bin/env bash
# exit when any command fails
set -e

BACKENDRESOURCEGROUP="networking"
LOCATION="westeurope"

do_resource_group()
{
    echo "Checking Resource Groups"
    if [ $(az group exists --name $BACKENDRESOURCEGROUP) = false ]; then
        az group create --name $BACKENDRESOURCEGROUP --location $LOCATION
    fi
    echo "End Resource Group"
}

do_virtual_network()
{
    echo "Start Virtual Network"
    az deployment group create \
    --name VirtualNetwork \
    --resource-group $BACKENDRESOURCEGROUP \
    --template-file networking.json \
    --parameters networking_params.json location=$LOCATION \
    --verbose
    echo "End Virtual Network"
}

do_resource_group
do_virtual_network
