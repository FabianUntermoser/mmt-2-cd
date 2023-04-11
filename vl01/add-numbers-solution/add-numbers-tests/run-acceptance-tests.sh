#!/bin/bash

cd ../add-numbers-cli/bin/Release/net6.0/publish/

if ./add 2>&1 >/dev/null | grep -v -q "Usage: add <number1> <number2>"; then
    echo "Wrong Output if no command line arguments passed"
    exit 1
fi

if ./add 1 2 2>&1 >/dev/null | grep -v -q "3"; then
  echo "Wrong Output for 1 + 2"
  exit 1
fi

if ./add -1 -2 2>&1 >/dev/null | grep -v -q "-3"; then
  echo "Wrong Output for -1 + -2"
  exit 1
fi
