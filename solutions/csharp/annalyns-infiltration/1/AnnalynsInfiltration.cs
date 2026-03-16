static class QuestLogic
{
    public static bool CanFastAttack(bool knightIsAwake)
    {
        if (knightIsAwake)
            return false;
        
        return true;
    }

    public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake)
    {
        if (knightIsAwake || archerIsAwake)
            return true;

        if (!knightIsAwake && !archerIsAwake && !prisonerIsAwake)
            return false;

        if (!knightIsAwake && !archerIsAwake && prisonerIsAwake)
            return true;
        
        return false;
    }

    public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake)
    {
        if (prisonerIsAwake && !archerIsAwake)
            return true;

        return false;
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
