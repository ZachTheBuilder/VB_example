Partial Class BankingDataSet
    Partial Class CustomersDataTable

        Private Sub CustomersDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.Full_NameColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

End Class
