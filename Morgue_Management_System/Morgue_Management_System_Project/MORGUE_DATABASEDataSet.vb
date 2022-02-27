Partial Class MORGUE_DATABASEDataSet
    Partial Public Class Chamber_TBDataTable
        Private Sub Chamber_TBDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.chamber_IDColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class
End Class
