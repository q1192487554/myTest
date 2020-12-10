// Fill out your copyright notice in the Description page of Project Settings.

#pragma once

#include "CoreMinimal.h"
#include "Kismet/BlueprintFunctionLibrary.h"
#include "MyTestBlueprintFunctionLibrary.generated.h"

/**
 * 
 */
UCLASS()
class MYTEST_API UMyTestBlueprintFunctionLibrary : public UBlueprintFunctionLibrary
{
	GENERATED_BODY()
public:
	UFUNCTION(BlueprintCallable, Category = "PluginTest")
		static void PluginFunction2();
};
