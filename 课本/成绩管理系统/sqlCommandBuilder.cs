using System.Data.SqlClient;

namespace MySchool
{
    internal class sqlCommandBuilder
    {
        private SqlDataAdapter da;

        public sqlCommandBuilder(SqlDataAdapter da)
        {
            this.da = da;
        }
    }
}