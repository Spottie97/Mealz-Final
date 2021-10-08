private void btnUpdate_Click(object sender, EventArgs e)
{
    double balance = getBalance("student_id");
    updateBalance(balance);
}

private double getBalance(string student_id)
{
    string sqlConnectionString = ""; // Replace "" with the connection string to your database.
    SqlConnection sqlConnection = new SqlConnection(sqlConnectionString); // Replace "" with sqlConnectionString

    sqlConnection.Open();

    string sqlOrdersBeingPrepared = "SELECT * FROM students WHERE student_id=@student_id";
    SqlCommand sqlCommand = new SqlCommand(sqlOrdersBeingPrepared, sqlConnection);

    sqlCommand.Parameters.AddWithValue("@student_id", student_id);
    SqlDataReader dataReader = ordersBeingPrepared.ExecuteReader();

    double balance;

    if (dataReader.HasRows)
    {
        balance = Convert.ToDouble(dataReader["column name"].ToDouble());
    }

    balance -= orderAmount;

    dataReader.Close();
    sqlConnection.Close();

    return balance;
}

private void updateBalance(double balance)
{
    string sqlConnectionString = ""; // Replace "" with the connection string to your database.
    SqlConnection sqlConnection = new SqlConnection(sqlConnectionString); // Replace "" with sqlConnectionString

    sqlConnection.Open();

    string sqlOrdersBeingPrepared = "UPDATE table SET column = @balance WHERE student_id = @student_id";
    SqlCommand sqlCommand = new SqlCommand(sqlOrdersBeingPrepared, sqlConnection);

    sqlCommand.Parameters.AddWithValue("@balance", balance);
    sqlCommand.Parameters.AddWithValue("@student_id", student_id);
    sqlCommand.ExecuteNonQuery();

    sqlConnection.Close();

    MessageBox.Show("Approved");
}