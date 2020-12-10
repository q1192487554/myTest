
// Fill out your copyright notice in the Description page of Project Settings.


#include "MyTestBlueprintFunctionLibrary.h"

#include "Engine.h"
#include <iostream>


//#include "windows.h"

void UMyTestBlueprintFunctionLibrary::PluginFunction2()
{
	GEngine->AddOnScreenDebugMessage(-1, 5.0f, FColor::Green, TEXT("eeeeeeeeeeeeeeeee"));

}