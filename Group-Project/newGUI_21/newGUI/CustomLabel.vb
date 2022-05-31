'These custom labels also store data associated with extra properties
Class CustomLabel
    Inherits Label
    Private _intMealEntry As Integer = -1
    Private _intExerciseEntry As Integer = -1
    Private _intFoodID As Integer = -1
    Private _intExerciseID As Integer = -1
    Private _intCalories As Integer = -1
    Private _intExerciseCaloriesBurned = -1
    Property _strFoodName As String = "-1"
    Property _strExerciseDescription As String = "-1"
    Property _dateTime As DateTime = Now

    Property _strMealType As String = "snack"

    Property _intMealtype As Integer = 3


    Public Property IntMealType() As Integer 'used for sorting of labels
        Get
            Return _intMealtype
        End Get
        Set(value As Integer)
            _intMealtype = value
            If value = 0 Then
                _strMealType = "breakfast"
            ElseIf value = 1 Then
                _strMealType = "lunch"

            ElseIf value = 2 Then
                _strMealType = "dinner"
            Else
                _strMealType = "snack"
            End If

        End Set
    End Property

    Public Property intMealEntryID() As Integer
        Get
            Return _intMealEntry
        End Get
        Set(value As Integer)
            _intMealEntry = value
        End Set
    End Property

    Public Property intExerciseEntryID() As Integer
        Get
            Return _intExerciseEntry
        End Get
        Set(value As Integer)
            _intExerciseEntry = value
        End Set
    End Property
    Public Property intFoodID() As Integer
        Get
            Return _intFoodID
        End Get
        Set(value As Integer)
            _intFoodID = value
        End Set
    End Property

    Public Property intExerciseID() As Integer
        Get
            Return _intExerciseID
        End Get
        Set(value As Integer)
            _intExerciseID = value
        End Set
    End Property
    Public Property intCalories() As Integer
        Get
            Return _intCalories
        End Get
        Set(value As Integer)
            _intCalories = value
        End Set
    End Property
    Public Property intExerciseCaloriesBurned() As Integer
        Get
            Return _intExerciseCaloriesBurned
        End Get
        Set(value As Integer)
            _intExerciseCaloriesBurned = value
        End Set
    End Property
    Public Property strFoodName() As String
        Get
            Return _strFoodName
        End Get
        Set(value As String)
            _strFoodName = value
        End Set
    End Property

    Public Property strExerciseDescription() As String
        Get
            Return _strExerciseDescription
        End Get
        Set(value As String)
            _strExerciseDescription = value
        End Set
    End Property

    Public Property strMealType() As String
        Get
            Return _strMealType
        End Get
        Set(value As String)
            _strMealType = value
            If _strMealType = "breakfast" Then
                _intMealtype = 0
            ElseIf _strMealType = "lunch" Then
                _intMealtype = 1
            ElseIf _strMealType = "dinner" Then
                _intMealtype = 2
            Else
                _intMealtype = 3
            End If
        End Set
    End Property


    Public Property DateTime() As DateTime
        Get
            Return _dateTime
        End Get
        Set(value As DateTime)
            _dateTime = value
        End Set
    End Property



End Class
