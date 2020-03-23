using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace ChemicalMVCDatabase.Models
{
  public class ChemicalDataAcessLayer
  {
    string connectionString = "Server=localhost;Database=chemicalDB;Uid=root;Pwd=hgm9?Ztd$;";

    // View all employees deails
    public IEnumerable<Chemical> ChemicalViewAll()
    {
      List<Chemical> lstchemical = new List<Chemical>();

      using (MySqlConnection sqlCon = new MySqlConnection(connectionString))
      {
        MySqlCommand sqlCmd = new MySqlCommand("ChemicalViewAll", sqlCon);
        sqlCmd.CommandType = CommandType.StoredProcedure;

        sqlCon.Open();
        MySqlDataReader rdr = sqlCmd.ExecuteReader();

        while (rdr.Read())
        {
          Chemical chemical = new Chemical();

          chemical.Chemical_ID = Convert.ToInt32(rdr["Chemical_ID"]);
          chemical.Chemical_Name = rdr["Chemical_Name"].ToString();
          chemical.Molecular_Weight = Convert.ToDecimal(rdr["Molecular_Weight"]);
          chemical.Product_Number = rdr["Product_Number"].ToString();
          chemical.Vendor = rdr["Vendor"].ToString();

          lstchemical.Add(chemical);
        }
        sqlCon.Close();
      }
      return lstchemical;
    }

    //Add chemical record
    public void ChemicalAddOrEdit(Chemical chemical)
    {
      using (MySqlConnection sqlCon = new MySqlConnection(connectionString))
      {
        MySqlCommand sqlCmd = new MySqlCommand("ChemicalAddOrEdit", sqlCon);
        sqlCmd.CommandType = CommandType.StoredProcedure;

        sqlCmd.Parameters.AddWithValue("_Chemical_ID", chemical.Chemical_ID);
        sqlCmd.Parameters.AddWithValue("_Chemical_Name", chemical.Chemical_Name);
        sqlCmd.Parameters.AddWithValue("_Molecular_Weight", chemical.Molecular_Weight);
        sqlCmd.Parameters.AddWithValue("_Product_Number", chemical.Product_Number);
        sqlCmd.Parameters.AddWithValue("_Vendor", chemical.Vendor);

        sqlCon.Open();
        sqlCmd.ExecuteNonQuery();
        sqlCon.Close();
      }
    }

    //View specific chemical information
    public Chemical ViewChemicalByID(int? id)
    {
      Chemical chemical = new Chemical();

      using (MySqlConnection sqlCon = new MySqlConnection(connectionString))
      {
        string mySqlQuery = "SELECT * FROM Chemical WHERE Chemical_ID= " + id;

        MySqlCommand sqlCmd = new MySqlCommand(mySqlQuery, sqlCon);

        sqlCon.Open();
        MySqlDataReader rdr = sqlCmd.ExecuteReader();

        while (rdr.Read())
        {
          chemical.Chemical_ID = Convert.ToInt32(rdr["Chemical_ID"]);
          chemical.Chemical_Name = rdr["Chemical_Name"].ToString();
          chemical.Molecular_Weight = Convert.ToDecimal(rdr["Molecular_Weight"]);
          chemical.Product_Number = rdr["Product_Number"].ToString();
          chemical.Vendor = rdr["Vendor"].ToString();
        }
      }
      return chemical;
    }
    //delete chemical from records
    public void DeleteChemicalByID(int? id)
    {
      using (MySqlConnection sqlCon = new MySqlConnection(connectionString))
      {
        MySqlCommand sqlCmd = new MySqlCommand("ChemicalDeleteByID", sqlCon);
        sqlCmd.CommandType = CommandType.StoredProcedure;

        sqlCmd.Parameters.AddWithValue("_Chemical_ID", id);

        sqlCon.Open();
        sqlCmd.ExecuteNonQuery();
        sqlCon.Close();
      }
    }

    public IEnumerable<Chemical> ChemicalSearchByValue(string searchString)
    {
      List<Chemical> filteredChemicals = new List<Chemical>();

      using (MySqlConnection sqlCon = new MySqlConnection(connectionString))
      {
        string mySqlQuery = "SELECT * FROM Chemical WHERE Chemical_Name LIKE CONCAT('%', '" + searchString + "' , '%') || Product_Number LIKE CONCAT('%', '" + searchString + "' , '%')";

        MySqlCommand sqlCmd = new MySqlCommand(mySqlQuery, sqlCon);

        sqlCon.Open();
        MySqlDataReader rdr = sqlCmd.ExecuteReader();

        while (rdr.Read())
        {
          Chemical chemical = new Chemical();

          chemical.Chemical_ID = Convert.ToInt32(rdr["Chemical_ID"]);
          chemical.Chemical_Name = rdr["Chemical_Name"].ToString();
          chemical.Molecular_Weight = Convert.ToDecimal(rdr["Molecular_Weight"]);
          chemical.Product_Number = rdr["Product_Number"].ToString();
          chemical.Vendor = rdr["Vendor"].ToString();

          filteredChemicals.Add(chemical);
        }
        sqlCon.Close();
      }
      return filteredChemicals;
    }
  }
}