using NBitcoin;
using QBitNinja.Client;

namespace BitcoinWallet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPrivKeyGen_Click(object sender, EventArgs e)
        {
            var privateKey = new Key();
            var btcPrivateKey = privateKey.GetWif(Network.Main).ToString();
            tbxPrivateKey.Text = btcPrivateKey;

            // generate a public key from the private key
            var btcPublicKey = privateKey.PubKey.ToString();

            // generate btc address from the private key
            var btcAddress = privateKey.GetAddress(ScriptPubKeyType.Segwit, Network.Main);
            tbxAddress1.Text = btcAddress.ToString();

            decimal balance = CheckBalance(btcAddress.ToString());
            tbxBalance1.Text = balance.ToString();
        }

        private void btnSeedPhrGen_Click(object sender, EventArgs e)
        {
            var mnemo = new Mnemonic(Wordlist.English, WordCount.Twelve);
            tbxMnemonic.Text = mnemo.ToString();

            var hdroot = mnemo.DeriveExtKey();
            var pkey = hdroot.Derive(new KeyPath("m/84'/0'/0'/0/0'"));
            var address = pkey.PrivateKey.PubKey.GetAddress(ScriptPubKeyType.Segwit, Network.Main);
            tbxAddress2.Text = address.ToString();

            decimal balance = CheckBalance(address.ToString());
            tbxBalance2.Text = balance.ToString();
        }

        private decimal CheckBalance(string address)
        {
            QBitNinjaClient client = new(Network.Main);
            decimal addressBalance = 0;
            try
            {
                var balanceMode = client.GetBalance(address, false).Result;
                if (balanceMode.Operations.Count == 0)
                    addressBalance = 0;
                else
                {
                    var unspentCoins = new List<Coin>();
                    foreach (var operation in balanceMode.Operations)
                    {
                        unspentCoins.AddRange(operation.ReceivedCoins.Select(coin => coin as Coin));
                        addressBalance = unspentCoins.Sum(x => x.Amount.ToDecimal(MoneyUnit.BTC));
                    }
                }
            }
            catch (Exception)
            {
                return addressBalance;
            }

            return addressBalance;
        }
    }
}
