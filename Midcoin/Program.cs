using NBitcoin;
Console.Clear();

Key pc = new Key(); // Private key
PubKey puc = pc.PubKey; // Public key
var pkh = puc.Hash; // public key hash
var MNA = pkh.GetAddress(Network.Main); // Main Net Address
// var Mna = pkh.GetAddress(Network.Main); // for the main network
var paymentScript = pkh.ScriptPubKey; // Payment script
var sMNA = paymentScript.GetDestinationAddress(Network.Main); // Same Main net Address 
BitcoinSecret mainNetPrivateKey = pc.GetBitcoinSecret(Network.Main); // Bitcoin secret
bool WifIsBitcoinSecret = mainNetPrivateKey ==  pc.GetWif(Network.Main);




// ADDRESS Console.WriteLine(puc.GetAddress(ScriptPubKeyType.Legacy, Network.main));
Console.WriteLine("Hello World " + pc);
Console.WriteLine(MNA.ScriptPubKey);
Console.WriteLine(MNA == sMNA); // true
System.Console.WriteLine(mainNetPrivateKey);

Console.ReadKey();