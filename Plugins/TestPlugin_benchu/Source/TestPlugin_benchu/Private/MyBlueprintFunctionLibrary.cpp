// Fill out your copyright notice in the Description page of Project Settings.


#include "MyBlueprintFunctionLibrary.h"
#include "Engine.h"
#include <iostream>


//#include "windows.h"

void UMyBlueprintFunctionLibrary::PluginFunction()
{   
    GEngine->AddOnScreenDebugMessage(-1, 5.0f, FColor::Green, TEXT("PluginFunciton_OK123123"));
	
}