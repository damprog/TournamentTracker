﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess
{
    public class SqlConnector : IDataConnection
    {
        // TODO - Make the CreatePrize method actually save to the database
        /// <summary>
        /// Saves a new prize to the database
        /// </summary>
        /// <param name="model">The prize information</param>
        /// <returns>The prize information, including the unique identifier.</returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {
           // using (IDbConnection connection = new System.Data.SqlClient. //(GlobalConfig.CnnString("Tournaments")))
            {
                model.Id = 1;
                return model;
            }
        }
    }
}
