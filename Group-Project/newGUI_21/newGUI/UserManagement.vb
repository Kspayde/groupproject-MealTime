Public Class UserManagement
    Private Property dataControl As New DatabaseControl

    'User object with user properties
    Public Class user
        Public Sub New()
            'default constructor
        End Sub

        'Creates new user object using parameters, NOTE the id is optional, probably better to just use the default constructor
        Public Sub New(_username As String, _password As String, _email As String,
                       _firstName As String, _lastName As String, _dob As Date, _sex As String, _height As Integer, Optional _id As Integer = 0)
            id = _id
            username = _username
            password = _password
            email = _email
            firstName = _firstName
            lastName = _lastName
            dob = _dob
            sex = _sex
            height = _height
        End Sub

        'NOTE - add BMI property
        'maybe add activity level
        Public Property id As Integer
        Public Property username As String
        Public Property password As String
        Public Property email As String
        Public Property firstName As String
        Public Property lastName As String
        Public Property dob As Date
        Public Property sex As String
        Public Property height As Integer
    End Class

    Public Sub createUser(userInfo As user)
        dataControl.runStatement(String.Format("INSERT INTO user_information (username, password_encrypted, DOB, first_name, last_Name, email, height_inches, sex) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}');",
                                            userInfo.username, userInfo.password, userInfo.dob, userInfo.firstName, userInfo.lastName, userInfo.email, userInfo.height, userInfo.sex))
    End Sub
    Public Function lookupUserByID(userID As Integer) As user
        Using data As DataTable = dataControl.getData(String.Format("SELECT * FROM user_information WHERE user_ID = {0};", userID))
            Return fillUserObject(data.Rows.Item(0))
        End Using
    End Function
    Public Function getAge(userID As Integer) As Integer
        'subtract this year from date of birth year and take note of that number estimatedDate
        'add that number to their birthdate and call that testDate
        'if testDate is greater than now, then add 1 to estimatedDate to get age
        Dim thisDob As Date = lookupUserByID(userID).dob

        Dim estimatedAge As Integer = Year(Now) - Year(thisDob)

        Dim testDate As DateTime = thisDob.AddYears(estimatedAge)

        If testDate >= Now Then
            estimatedAge = estimatedAge + 1
        Else
            estimatedAge = estimatedAge
        End If

        Dim actualAge As Integer = estimatedAge

        Return actualAge

    End Function
    Public Function lookupUserByUsername(username As String) As user
        Using data As DataTable = dataControl.getData(String.Format("SELECT * FROM user_information WHERE username = '{0}';", username))
            If data.Rows.Count > 0 Then
                Return fillUserObject(data.Rows.Item(0))
            Else
                Dim emptyUser As New user
                With emptyUser
                    .id = 0
                End With
                Return emptyUser
            End If
        End Using
    End Function
    Public Sub updateUser(userInfo As user)
        dataControl.runStatement(String.Format("UPDATE user_information SET username = '{0}' , password_encrypted = '{1}', DOB = '{2}', first_name = '{3}', last_Name = '{4}', email = '{5}', height_inches = {6}, sex = '{7}' WHERE user_ID = {8};",
                                            userInfo.username, userInfo.password, userInfo.dob, userInfo.firstName, userInfo.lastName, userInfo.email, userInfo.height, userInfo.sex, userInfo.id))
    End Sub
    Public Sub deleteUser(userID As Integer)
        dataControl.runStatement(String.Format("DELETE FROM user_information WHERE user_ID = {0};", userID))
    End Sub

    Private Function fillUserObject(data As DataRow) As user
        'All these values shouldn't be null but until end production this is to prevent errors when reading from the database
        '[IF] database data is NULL [THEN] set it VB NULL [ELSE] set value
        Return New user(
            If(IsDBNull(data.Item("username")), Nothing, data.Item("username")),
            If(IsDBNull(data.Item("password_encrypted")), Nothing, data.Item("password_encrypted")),
            If(IsDBNull(data.Item("email")), Nothing, data.Item("email")),
            If(IsDBNull(data.Item("first_name")), Nothing, data.Item("first_name")),
            If(IsDBNull(data.Item("last_Name")), Nothing, data.Item("last_Name")),
            If(IsDBNull(data.Item("DOB")), Nothing, data.Item("DOB")),
            If(IsDBNull(data.Item("sex")), Nothing, data.Item("sex")),
            If(IsDBNull(data.Item("height_inches")), Nothing, data.Item("height_inches")),
            If(IsDBNull(data.Item("user_ID")), Nothing, data.Item("user_ID")))
    End Function
End Class