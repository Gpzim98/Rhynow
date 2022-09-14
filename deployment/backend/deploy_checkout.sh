#!/usr/bin/env bash
# exit when any command fails
set -e

APPNAME="devcheckout"

cd ../../src/Consumers/Checkout/
func azure functionapp publish $APPNAME --dotnet