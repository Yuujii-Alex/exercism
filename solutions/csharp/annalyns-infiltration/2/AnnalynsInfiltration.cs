static class QuestLogic
{
    public static bool CanFastAttack(bool knightIsAwake)
    {
        return !knightIsAwake;
    }

    public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake)
    {
        return (knightIsAwake || archerIsAwake || prisonerIsAwake);
    }

    public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake)
    {
        return prisonerIsAwake && !archerIsAwake;
    }

    public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)
    {
        // Als de hond mee is: kan alleen redden als de archer slaapt
        if (petDogIsPresent)
            return !archerIsAwake;
    
        // Zonder hond: gevangene moet wakker zijn en beide kidnappers moeten slapen
        return prisonerIsAwake && !knightIsAwake && !archerIsAwake;
    }

}
