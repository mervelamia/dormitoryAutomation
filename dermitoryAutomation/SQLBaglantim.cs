﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace YurtKayitSistemi
{
    public class SQLBaglantim
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan= new SqlConnection(@"Data Source=DROGON\WOLVOX8;Initial Catalog=YurtOtomasyonu;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
