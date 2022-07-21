#!/usr/bin/env bash
# exit when any command fails
set -e

BACKENDRESOURCEGROUP="backend"
APPNAME="devcheckoutrhynow"

REQUESTS_CA_BUNDLE=./opt/azure-cli/lib/python3.10/site-packages/certifi/cacert.pem
do_deploy_function_app()
{
    echo "Deploying Function App"
    cd ../src/Checkout/
    git archive -o /tmp/checkout.zip HEAD
    az functionapp deployment source config-zip \
    -g backend \
    -n devcheckoutrhynow \
    --src "/tmp/checkout.zip"
    rm "/tmp/checkout.zip"
    echo "End Deploying Function App"
}

do_deploy_function_app
