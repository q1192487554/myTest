// Copyright Epic Games, Inc. All Rights Reserved.

#include "TestPlugin_benchu.h"

#define LOCTEXT_NAMESPACE "FTestPlugin_benchuModule"

void FTestPlugin_benchuModule::StartupModule()
{
	// This code will execute after your module is loaded into memory; the exact timing is specified in the .uplugin file per-module
}

void FTestPlugin_benchuModule::ShutdownModule()
{
	// This function may be called during shutdown to clean up your module.  For modules that support dynamic reloading,
	// we call this function before unloading the module.
}

#undef LOCTEXT_NAMESPACE
	
IMPLEMENT_MODULE(FTestPlugin_benchuModule, TestPlugin_benchu)