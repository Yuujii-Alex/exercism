using System.Numerics;

public static class DiffieHellman
{
    private static Random rng = new();
    public static BigInteger PrivateKey(BigInteger primeP) => rng.Next(1, (int)primeP);

    // use BigInteger.ModPow() instead of Math.Pow() since double has less digits and cuts off!
    public static BigInteger PublicKey(BigInteger primeP, BigInteger primeG, BigInteger privateKey) => BigInteger.ModPow(primeG, privateKey, primeP);

    public static BigInteger Secret(BigInteger primeP, BigInteger publicKey, BigInteger privateKey) => BigInteger.ModPow(publicKey, privateKey, primeP);
}