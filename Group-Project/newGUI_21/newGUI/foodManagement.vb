Public Class foodManagement
    Private Property datacontrol As New DatabaseControl

    'Defining the properties of a food object
    Public Class foodObject
        Public Property foodId As Integer
        Public Property food As String
        Public Property calories As Integer
        Public Property fat As Integer
        Public Property carbs As Integer
        Public Property protein As Integer
        Public Property servingSizeAmount As Decimal
        Public Property servingSizeUnit As String
        Public Property userId As Integer
        Public Property share As Boolean
        Public Property common As Boolean
        Public Property ingredient As Boolean
        Public Property cholesterol As Integer
        Public Property sodium As Integer
        Public Property fiber As Integer
        Public Property sugar As Integer
        Public Property transFat As Integer
        Public Property satFat As Integer
    End Class

    'Fills the properties of a food object with information from a query to the DB and returns the object
    Private Function fillFood(data As DataTable) As foodObject
        Dim foodInfo As New foodObject

        'Fills the datatable with the information form the database, checking for NULLS
        With foodInfo
            .foodId = IIf(Not IsDBNull(data.Rows.Item(0).Item("food_ID")), data.Rows.Item(0).Item("food_ID"), Nothing)
            .food = IIf(Not IsDBNull(data.Rows.Item(0).Item("food")), data.Rows.Item(0).Item("food"), Nothing)
            .calories = IIf(Not IsDBNull(data.Rows.Item(0).Item("food_calories")), data.Rows.Item(0).Item("food_calories"), Nothing)
            .fat = IIf(Not IsDBNull(data.Rows.Item(0).Item("total_fat")), data.Rows.Item(0).Item("total_fat"), Nothing)
            .carbs = IIf(Not IsDBNull(data.Rows.Item(0).Item("total_carbohydrates")), data.Rows.Item(0).Item("total_carbohydrates"), Nothing)
            .protein = IIf(Not IsDBNull(data.Rows.Item(0).Item("protein")), data.Rows.Item(0).Item("protein"), Nothing)
            .servingSizeAmount = IIf(Not IsDBNull(data.Rows.Item(0).Item("serving_size_amount")), data.Rows.Item(0).Item("serving_size_amount"), Nothing)
            .servingSizeUnit = IIf(Not IsDBNull(data.Rows.Item(0).Item("serving_size_unit")), data.Rows.Item(0).Item("serving_size_unit"), Nothing)
            .userId = IIf(Not IsDBNull(data.Rows.Item(0).Item("user_ID")), data.Rows.Item(0).Item("user_ID"), Nothing)
            .share = IIf(Not IsDBNull(data.Rows.Item(0).Item("shared")), data.Rows.Item(0).Item("shared"), Nothing)
            .common = IIf(Not IsDBNull(data.Rows.Item(0).Item("common")), data.Rows.Item(0).Item("common"), Nothing)
            .ingredient = IIf(Not IsDBNull(data.Rows.Item(0).Item("ingredient")), data.Rows.Item(0).Item("ingredient"), Nothing)
            .cholesterol = IIf(Not IsDBNull(data.Rows.Item(0).Item("cholesterol")), data.Rows.Item(0).Item("cholesterol"), Nothing)
            .sodium = IIf(Not IsDBNull(data.Rows.Item(0).Item("sodium")), data.Rows.Item(0).Item("sodium"), Nothing)
            .fiber = IIf(Not IsDBNull(data.Rows.Item(0).Item("dietary_fiber")), data.Rows.Item(0).Item("dietary_fiber"), Nothing)
            .sugar = IIf(Not IsDBNull(data.Rows.Item(0).Item("total_sugars")), data.Rows.Item(0).Item("total_sugars"), Nothing)
            .transFat = IIf(Not IsDBNull(data.Rows.Item(0).Item("trans_fat")), data.Rows.Item(0).Item("trans_fat"), Nothing)
            .satFat = IIf(Not IsDBNull(data.Rows.Item(0).Item("saturated_fat")), data.Rows.Item(0).Item("saturated_fat"), Nothing)
        End With

        Return foodInfo
    End Function

    'In Progress
    'Private Function fillFoodObjects(data As DataTable) As List(Of foodObject)

    '    'All these values shouldn't be null but until end production this is to prevent errors when reading from the database
    '    '[IF] database data is NULL [THEN] set it VB NULL [ELSE] set value

    '    Dim returnList As New List(Of foodObject)
    '    Dim index As Integer = 0

    '    For Each r In data.Rows
    '        Dim food As New foodObject
    '        With food
    '            .firstName = If(IsDBNull(r.item(index).Item("username")), Nothing, r.item(index).Item("username"))
    '            'properties

    '        End With
    '        returnList.Add(food)
    '        index += 1
    '    Next

    '    Return returnList

    'End Function

    'Creates a new food entry in the database
    Public Sub createfood(food As foodObject)

        Dim query As String = String.Format("INSERT INTO foods (food, food_calories, total_fat, total_carbohydrates, protein, serving_size_amount, serving_size_unit, user_ID, shared, common, ingredient, cholesterol, sodium, dietary_fiber, total_sugars, trans_fat, saturated_fat) VALUES ('{0}', {1}, {2}, {3}, {4}, {5}, '{6}', {7}, {8}, {9}, {10}, {11}, {12}, {13}, {14}, {15}, {16})", food.food, food.calories, food.fat, food.carbs, food.protein, food.servingSizeAmount, food.servingSizeUnit, food.userId, food.share, food.common, food.ingredient, food.cholesterol, food.sodium, food.fiber, food.sugar, food.transFat, food.satFat)

        datacontrol.runStatement(query)

    End Sub

    'Returns a food object from the database given a food id that exists in the database

    Public Function getfood(id As Integer) As foodObject

        Dim foodItem As New DataTable

        foodItem = datacontrol.getData(String.Format("SELECT * FROM foods WHERE food_ID = {0}", id))

        Return fillFood(foodItem)

    End Function

    'In progress
    'Public Function getfood(foodName As String) As foodObject

    '    Dim foodItem As New DataTable

    '    foodItem = datacontrol.getData(String.Format("SELECT * FROM foods WHERE food LIKE '{0}%'", foodName))

    '    Return fillFood(foodItem)

    'End Function

    'Uppdates the information in a food entry
    Public Sub updatefood(food As foodObject)

        'This is just a test at the moment, works though
        Dim query As String = String.Format("UPDATE foods SET food = '{0}', food_calories = {1}, total_fat = {2}, total_carbohydrates = {3}, protein = {4}, serving_size_amount = {5}, serving_size_unit = '{6}', shared = {7}, common = {8}, ingredient = {9}, cholesterol = {10}, sodium = {11}, dietary_fiber = {12}, total_sugars = {13}, trans_fat = {14}, saturated_fat = {15} WHERE food_ID = {16}", food.food, food.calories, food.fat, food.carbs, food.protein, food.servingSizeAmount, food.servingSizeUnit, food.share, food.common, food.ingredient, food.cholesterol, food.sodium, food.fiber, food.sugar, food.transFat, food.satFat, food.foodId)
        datacontrol.runStatement(query)

    End Sub

    Public Sub deletefood(id As Integer)

        Dim query As String = String.Format("DELETE FROM foods WHERE food_ID = {0}", id)

        datacontrol.runStatement(query)

    End Sub
End Class
