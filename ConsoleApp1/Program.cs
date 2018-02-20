using System;
using NBitcoin;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NBitcoin.Crypto;
using NBitcoin.DataEncoders;
using NBitcoin.Protocol;
using NBitcoin.RPC;
using System.Threading;
using System.Threading.Tasks;
namespace ConsoleApp1
{
    
    class Program
    {



        static void Main(string[] args)
        {
           // NBitcoin.Key privateKey = new NBitcoin.Key(); // generate a random private key
          /*  var secret = new BitcoinSecret("cTssqddTPPHpVhfcwm1TaATy4ekJoJudvUASyiPpECYKCBWs7Aus");
            var key = secret.PrivateKey;
            Console.WriteLine("private key:{0}", key);
            NBitcoin.PubKey publicKey = key.PubKey;
            Console.WriteLine("pub key:{0}", publicKey);
            Console.WriteLine("adress:{0}", publicKey.GetAddress(NBitcoin.Network.TestNet));
            Console.ReadLine();*/
           /* var key = new Key();
            Console.WriteLine(key);
            PubKey pubkey = key.PubKey;
            Console.WriteLine("this is my publickey",pubkey);
            Console.ReadLine();*/
              //Key key = new Key();


              var secret = new BitcoinSecret("cTssqddTPPHpVhfcwm1TaATy4ekJoJudvUASyiPpECYKCBWs7Aus");
              var key = secret.PrivateKey;
              Console.WriteLine(key.PubKey.GetAddress(Network.TestNet));

              Transaction tx = new Transaction();
              var input = new TxIn();
              input.PrevOut = new OutPoint(new uint256("50905cfc4500e8b532cf38efe13d2181c901dc5eef1223fc56ea69d159a69b3e"), 1);
              input.ScriptSig = secret.GetAddress().ScriptPubKey;
              tx.AddInput(input);


              var output = new TxOut();
              var distination = BitcoinAddress.Create("muAh7jKQA9J5L7ZpaFDbbEErXMoRcAVtuS");
              Money fee = Money.Satoshis(40000);
              output.Value = Money.Coins(0.01m)- fee;
              output.ScriptPubKey = distination.ScriptPubKey;
              tx.AddOutput(output);
              tx.Sign(secret,false);
          /*  var node = Node.Connect(Network.TestNet, "52.41.73.185:8333");
              node.VersionHandshake();
              node.SendMessage(new InvPayload(tx));
              node.SendMessage(new TxPayload(tx));
              Thread.Sleep(4000);
              node.Disconnect(); */

              /* NBitcoin.Key privateKey = new NBitcoin.Key(); // generate a random private key
               NBitcoin.PubKey publicKey = privateKey.PubKey;
               Console.WriteLine(publicKey);
               Console.WriteLine(publicKey.GetAddress(NBitcoin.Network.Main)); // 1PUYsjwfNmX64wS368ZR5FMouTtUmvtmTY
               Console.WriteLine(publicKey.GetAddress(NBitcoin.Network.TestNet)); // n3zWAo2eBnxLr3ueohXnuAa8mTVBhxmPhq
               var publicKeyHash = publicKey.Hash;
               Console.WriteLine(publicKeyHash); // f6889b21b5540353a29ed18c45ea0031280c42cf
               var mainNetAddress = publicKeyHash.GetAddress(NBitcoin.Network.Main);
               var testNetAddress = publicKeyHash.GetAddress(NBitcoin.Network.TestNet);
               Console.WriteLine(mainNetAddress); // 1PUYsjwfNmX64wS368ZR5FMouTtUmvtmTY
               Console.WriteLine("nettestadress: {0}", testNetAddress); // n3zWAo2eBnxLr3ueohXnuAa8mTVBhxmPhq
               Console.WriteLine(testNetAddress.ScriptPubKey);
               NBitcoin.BitcoinSecret mainNetPrivateKey = privateKey.GetBitcoinSecret(NBitcoin.Network.Main);  // generate our Bitcoin secret(also known as Wallet Import Format or simply WIF) from our private key for the mainnet
               NBitcoin.BitcoinSecret testNetPrivateKey = privateKey.GetBitcoinSecret(NBitcoin.Network.TestNet);  // generate our Bitcoin secret(also known as Wallet Import Format or simply WIF) from our private key for the testnet
               Console.WriteLine("mainNetPrivateKey:{0}",mainNetPrivateKey); // L5B67zvrndS5c71EjkrTJZ99UaoVbMUAK58GKdQUfYCpAa6jypvn
               Console.WriteLine("testNetPrivateKey:{0}",testNetPrivateKey); // cVY5

               // Create a client
               QBitNinja.Client.QBitNinjaClient client = new QBitNinja.Client.QBitNinjaClient(NBitcoin.Network.Main);
               // Parse transaction id to NBitcoin.uint256 so the client can eat it
               var transactionId = NBitcoin.uint256.Parse("f13dc48fb035bbf0a6e989a26b3ecb57b84f85e0836e777d6edf60d87a4a2d94");
               // Query the transaction
               QBitNinja.Client.Models.GetTransactionResponse transactionResponse = client.GetTransaction(transactionId).Result;


               List<NBitcoin.ICoin> receivedCoins = transactionResponse.ReceivedCoins;
               foreach (var coin in receivedCoins)
               {
                   NBitcoin.Money amount = (NBitcoin.Money)coin.Amount;

                   Console.WriteLine("BitCoinsAmount:{0}",amount.ToDecimal(NBitcoin.MoneyUnit.BTC));
                   var paymentScript = coin.TxOut.ScriptPubKey;
                   Console.WriteLine(paymentScript);  // It's the ScriptPubKey
                   var address = paymentScript.GetDestinationAddress(NBitcoin.Network.Main);
                   Console.WriteLine(address); // 1HfbwN6Lvma9eDsv7mdwp529tgiyfNr7jc
                   Console.WriteLine();
                  c
               }
               NBitcoin.Transaction transaction = transactionResponse.Transaction;
               var outputs = transaction.Outputs ;
               foreach (NBitcoin.TxOut output in outputs)
               {
                   NBitcoin.Money amount = output.Value;

                   Console.WriteLine(amount.ToDecimal(NBitcoin.MoneyUnit.BTC));
                   var paymentScript = output.ScriptPubKey;
                   Console.WriteLine(paymentScript);  // It's the ScriptPubKey
                   var address = paymentScript.GetDestinationAddress(NBitcoin.Network.Main);
                   Console.WriteLine(address);
                   Console.WriteLine();
                   Console.ReadLine();
               }
               var inputs = transaction.Inputs;
               foreach (NBitcoin.TxIn input in inputs)
               {
                   NBitcoin.OutPoint previousOutpoint = input.PrevOut;
                   Console.WriteLine(previousOutpoint.Hash); // hash of prev tx
                   Console.WriteLine(previousOutpoint.N); // idx of out from prev tx, that has been spent in the current tx
                   Console.WriteLine();
               }
               Console.ReadLine();*/




        }
    }

}
