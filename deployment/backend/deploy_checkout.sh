#!/usr/bin/env bash
# exit when any command fails
set -e

APPNAME="devcheckout"

cd ../../src/WebUI/Checkout/
func azure functionapp publish $APPNAME --dotnet