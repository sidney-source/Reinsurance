namespace Reinsurance
{
    internal class MySqlconnection
    {
        private string connectionstring;

        public MySqlconnection(string connectionstring)
        {
            this.connectionstring = connectionstring;
        }
    }
}