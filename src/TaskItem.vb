Public Class TaskItem

    Private _id As Guid
    Private _title As String
    Private _description As String
    Private _isCompleted As Boolean
    Private _createdAt As DateTime
    Private _completedAt As Nullable(Of DateTime)

    Public ReadOnly Property Id As Guid
        Get
            Return _id
        End Get
    End Property

    Public ReadOnly Property Title As String
        Get
            Return _title
        End Get
    End Property

    Public ReadOnly Property Description As String
        Get
            Return _description
        End Get
    End Property

    Public ReadOnly Property IsCompleted As Boolean
        Get
            Return _isCompleted
        End Get
    End Property

    Public ReadOnly Property CreatedAt As DateTime
        Get
            Return _createdAt
        End Get
    End Property

    Public ReadOnly Property CompletedAt As Nullable(Of DateTime)
        Get
            Return _completedAt
        End Get
    End Property

    Public Sub New(i As Guid, t As String, d As String)
        _id = i
        _title = t
        _description = d
        _isCompleted = False
        _createdAt = DateTime.Now
        _completedAt = Nothing
    End Sub

    Public Sub Complete()
        _isCompleted = True
        _completedAt = DateTime.Now
    End Sub

End Class
