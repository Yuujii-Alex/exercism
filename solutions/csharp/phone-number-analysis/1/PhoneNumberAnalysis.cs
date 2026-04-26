public static class PhoneNumber
{
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {
        string[] numberParts = phoneNumber.Split('-');

		if (phoneNumber == null)
            throw new ArgumentNullException(nameof(phoneNumber));

        bool isNewYork = false;
        if (numberParts[0] == "212")
            isNewYork = true;    

        bool isFake = false;
        if (numberParts[1] == "555")
            isFake = true;

        string localNumber = numberParts[2];
        return (isNewYork, isFake, localNumber);
    }

    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo)
    {
        return phoneNumberInfo.IsFake;
	}
}
