﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace YazılımlabABRCB
{
   public static class Globals
    {
        public static MySqlConnection con = new MySqlConnection("Server=localhost;Database=TestOtomasyon;user=root;pwd='PeezCheck61.';");
    }
}
