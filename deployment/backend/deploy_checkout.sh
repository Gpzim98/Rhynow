#!/usr/bin/env bash
# exit when any command fails
set -e

BACKENDRESOURCEGROUP="backend6"
APPNAME="devcheckoutrhynow6"

do_deploy_function_app()
{
    echo "Deploying Function App"
    cd ../../src/WebUI/Checkout/
    git archive -o /tmp/checkout.zip HEAD
    az functionapp deployment source config-zip \
    -g $BACKENDRESOURCEGROUP \
    -n $APPNAME \
    --src "/tmp/checkout.zip"
    rm "/tmp/checkout.zip"
    echo "End Deploying Function App"
}

do_deploy_function_app
