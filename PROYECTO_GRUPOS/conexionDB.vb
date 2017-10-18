Imports MySql.Data.MySqlClient
Imports MySql.Data

Module conexionDB
    Public conn As New MySqlConnection("Server= localhost; User id = root; password=12345;")
    Public datatable As New DataTable
    Public table As New DataSet
    Public sql As String = ""
    Public reader As MySqlDataReader
    Public dAdapter As MySqlDataAdapter
    Public connection_db As New MySqlConnection
    Public user As String


    'Function who start the connection with the DB and handle the possible errors.'
    Public Function connect(ByVal db As String)
        Try
            connection_db = New MySqlConnection("Server=localhost; Database= " + db + "; User id = root;  password=12345;")
            connection_db.Open()
            Return True
        Catch ex As Exception
            MsgBox("The connection could not be established.", 16, "Connection Error")
            Return False
        End Try
    End Function


    'Sub procedure who handle the login process.'
    Public Sub login(ByVal username, ByVal password)
        Try
            If connect("dollarsDB") = True Then
                Form1.loginPB.Visible = True
                Form1.loginPB.Increment(50)
                Dim found As Boolean

                Dim command As MySqlCommand = New MySqlCommand("select * from users where username = '" + username + "';", connection_db)
                reader = command.ExecuteReader()

                While reader.Read()
                    If ((reader.GetString(1) = username)) Then
                        Form1.loginPB.Increment(25)

                        If ((reader.GetString(2) = password)) Then
                            chat.Show()
                            Form1.loginPB.Increment(25)
                            Form1.loginPB.Visible = False
                            chat.ToolStripStatusLabel1.Text = "Connected as " + username
                            Form1.Close()
                        Else
                            MsgBox("The password is incorrect.", 16, "Incorrect Passoword.")
                            Form1.loginPB.Visible = False
                        End If
                        found = True

                    End If
                End While

                If found = False Then
                    MsgBox("User no found in the chat database.", 16, "Username not Found.")
                    Form1.loginPB.Visible = False
                End If



            End If
        Catch ex As Exception
            MsgBox(ex.ToString, 16, "Username not Found.")
        End Try
    End Sub

    'Sub procedure who handle the sign up process.'
    Public Sub signUp(ByVal username, ByVal password, ByVal name)
        Try
            If connect("dollarsDB") = True Then
                Dim command As MySqlCommand = New MySqlCommand("select * from users where username = '" + username + "'", connection_db)
                reader = command.ExecuteReader()

                If ((reader.HasRows = False)) Then
                    'Close de reader in order to be able to execute another query.'
                    reader.Close()

                    'Preparing the insert query.'
                    command = New MySqlCommand("INSERT INTO users (id, username, password, name) VALUES (NULL,@USERNAME,@PASSWORD,@NAME)", connection_db)


                    command.Prepare()

                    command.Parameters.AddWithValue("@USERNAME", username)
                    command.Parameters.AddWithValue("@PASSWORD", password)
                    command.Parameters.AddWithValue("@NAME", name)

                    'Executing the insert query.'
                    command.ExecuteNonQuery()

                    'Showing to the username that the registration process is successful.'
                    MsgBox("The registration process was successful.", 0, "New User Registered.")

                    'Finishing the DB connection.'
                    connection_db.Close()

                    'Closing the Sign Up Form.'
                    singupForm.Close()



                Else
                    MsgBox("The username alreade exists in the system", 16, "Repeated Username.")
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.ToString, 16, "Username not Found.")
        End Try
    End Sub

    'Sub procedure who handle the sign up process.'
    Public Sub updatePassword(ByVal username, ByVal newPassword)
        Try
            If connect("dollarsDB") = True Then
                Dim command As MySqlCommand = New MySqlCommand("select * from users where username = '" + username + "'", connection_db)
                reader = command.ExecuteReader()

                If ((reader.HasRows = False)) Then
                    'Close de reader in order to be able to execute another query.'
                    reader.Close()

                    'Preparing the insert query.'
                    command = New MySqlCommand("UPDATE users SET PASSWORD = @NEWPASSWORD WHERE USERNAME = @USERNAME", connection_db)


                    command.Prepare()

                    command.Parameters.AddWithValue("@USERNAME", username)
                    command.Parameters.AddWithValue("@NEWPASSWORD", newPassword)

                    'Executing the insert query.'
                    command.ExecuteNonQuery()

                    'Showing to the username that the registration process is successful.'
                    MsgBox("Your password has been updated.", 0, "New Password.")
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.ToString, 16, "Username not Found.")
        End Try
    End Sub

End Module