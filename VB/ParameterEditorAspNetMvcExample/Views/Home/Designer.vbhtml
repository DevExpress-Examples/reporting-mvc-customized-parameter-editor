<script type="text/javascript">
    function registerParameters(s) {
        // Removes an existing parameter type.
        s.RemoveParameterType("System.DateTime");
    }
</script>

@Html.DevExpress().ReportDesigner(
                Sub(settings)
                    settings.Name = "ReportDesigner1"
                    settings.ClientSideEvents.BeforeRender = "registerParameters"
                End Sub).BindToUrl("TestReport").GetHtml()
