// Copyright Epic Games, Inc. All Rights Reserved.

#pragma once


#include "Misc/NetworkVersion.h"

#include "CoreMinimal.h"
#include "GameFramework/GameModeBase.h"
#include "TPSGameMode.generated.h"


UCLASS(minimalapi)
class ATPSGameMode : public AGameModeBase
{
	GENERATED_BODY()

public:
	ATPSGameMode();

	static bool ReturnTrue(uint32, uint32);
};



