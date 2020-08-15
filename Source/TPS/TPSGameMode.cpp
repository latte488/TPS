// Copyright Epic Games, Inc. All Rights Reserved.

#include "TPSGameMode.h"
#include "TPSCharacter.h"
#include "UObject/ConstructorHelpers.h"

#include "Misc/NetworkVersion.h"



ATPSGameMode::ATPSGameMode()
{
	FNetworkVersion::IsNetworkCompatibleOverride.BindStatic(&ATPSGameMode::ReturnTrue);

	// set default pawn class to our Blueprinted character
	static ConstructorHelpers::FClassFinder<APawn> PlayerPawnBPClass(TEXT("/Game/ThirdPersonCPP/Blueprints/ThirdPersonCharacter"));
	if (PlayerPawnBPClass.Class != NULL)
	{
		DefaultPawnClass = PlayerPawnBPClass.Class;
	}
}

bool ATPSGameMode::ReturnTrue(uint32, uint32)
{
	return true;
}
