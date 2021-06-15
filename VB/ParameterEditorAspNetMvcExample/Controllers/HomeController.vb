Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult
        Return View()
    End Function

    Function Designer() As ActionResult
    Dim model As Models.ReportDesignerModel = New Models.ReportDesignerModel()
    Return View(model)
    End Function

    Function Viewer() As ActionResult
        Return View()
    End Function

#Region "listemployees"
    ' Create an Employee list and serialize it to JSON.
    Public Function ListEmployees() As ActionResult
        Dim employees = New System.Collections.Generic.List(Of Employee)()
        employees.Add(New Employee() With {.id = 2, .parentId = 0,
                      .name = "Andrew Fuller", .title = "Vice President"})
        employees.Add(New Employee() With {.id = 1, .parentId = 5,
                      .name = "Nancy Davolio", .title = "Sales Representative"})
        employees.Add(New Employee() With {.id = 3, .parentId = 5,
                      .name = "Janet Leverling", .title = "Sales Representative"})
        employees.Add(New Employee() With {.id = 4, .parentId = 5,
                      .name = "Margaret Peacock", .title = "Sales Representative"})
        employees.Add(New Employee() With {.id = 5, .parentId = 2,
                      .name = "Steven Buchanan", .title = "Sales Manager"})
        Return Json(employees, JsonRequestBehavior.AllowGet)
    End Function
#End Region
End Class
