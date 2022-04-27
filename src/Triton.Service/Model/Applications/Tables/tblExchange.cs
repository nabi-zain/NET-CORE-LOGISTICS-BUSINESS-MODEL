using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;
using System.ComponentModel;
using System.Net;
using System.Security.Principal;
using System.Xml;
using System.IO;

namespace Triton.Model.Applications.Tables
{
    [Table("tblExchange")]
    public class tblExchange
    {
        /*TODO Repo methods
        #region Variables
        private HttpWebRequest _HttpRequest;
        private byte[] _HttpRequestBody;
        #endregion
        #region Constructors
         <SUMMARY>
         Init class
         </SUMMARY>
         <PARAM name="uri">Request URI</PARAM>
         <PARAM name="body">Request body (byte array)</PARAM>
         <PARAM name="methodName">Request method name</PARAM>
         <PARAM name="contentType">Request Content type</PARAM>
         <PARAM name="httpRequestHeaders">Request HTTP Headers</PARAM>
         

        public Exchange(string uri, byte[] body, string methodName, string contentType, WebHeaderCollection httpRequestHeaders)
        {
            try
            {
                WindowsIdentity winId = (WindowsIdentity)HttpContext.Current.User.Identity;
                WindowsImpersonationContext ctx = null;
                // Start impersonating.
                ctx = winId.Impersonate();
                // Now impersonating.

                _HttpRequest = (System.Net.HttpWebRequest)HttpWebRequest.Create(uri);
                _HttpRequest.Credentials = CredentialCache.DefaultCredentials;
                _HttpRequestBody = body;
                _HttpRequest.Method = methodName;
                //_HttpRequest.Headers = (httpRequestHeaders ?? new WebHeaderCollection);
                _HttpRequest.ContentType = contentType;
                if (ctx != null)
                    ctx.Undo();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
         <SUMMARY>
        Init class
         </SUMMARY>
        /// <PARAM name="uri">Request URI</PARAM>
        /// <PARAM name="body">Request body (string)</PARAM>
        /// <PARAM name="methodName">Request method name</PARAM>
        /// <PARAM name="contentType">Request Content type</PARAM>
        /// <PARAM name="httpRequestHeaders">Request HTTP Headers</PARAM>
        public Exchange(string uri, string body, string methodName, string contentType, WebHeaderCollection httpRequestHeaders)
            : this(uri, Encoding.UTF8.GetBytes(body), methodName, contentType, httpRequestHeaders)
        { }
        #endregion
        #region Methods
        /// <SUMMARY>
        /// Run request
        /// </SUMMARY>
        /// <RETURNS>XML document containting response XML</RETURNS>
        public XmlDocument RunRequest()
        {
            XmlDocument xml = new XmlDocument();
            try
            {
                _HttpRequest.ContentLength = _HttpRequestBody.Length;
                Stream requestStream = _HttpRequest.GetRequestStream();
                requestStream.Write(_HttpRequestBody, 0, _HttpRequestBody.Length);
                requestStream.Close();
                WebResponse httpResponse = (System.Net.HttpWebResponse)_HttpRequest.GetResponse();
                // handles methods like move, etc that don't return anything
                if (httpResponse.ContentLength == 0)
                    xml.LoadXml("<RESPONSE><ZEROCONTENTLENGTH><method>" + _HttpRequest.Method + "</method></ZEROCONTENTLENGTH></RESPONSE>");
                else
                {
                    Stream receiveStream = httpResponse.GetResponseStream();
                    StreamReader sr = new StreamReader(receiveStream, System.Text.Encoding.GetEncoding("utf-8"));
                    string xmlResult = sr.ReadToEnd();
                    // this is a very stupid exchange xml "bug"
                    // XmlDocument.LoadXml returns an error if the tag starts with 0 (i.e.: <dav:0x008a></>)
                    // so we must change the xml's :0x to :x Exchange doesn't care about it :)
                    xmlResult = xmlResult.Replace(":0x", ":x");
                    xml.LoadXml(xmlResult);
                    httpResponse.Close();
                }
            }
            catch (Exception ex)
            {
                // A few of the most important and common error.
                //
                // 403 - Forbidden      - This means there is not enough access to create this folder.
                // 405 - Method not allowed - This can mean the user is overwriting a folder (among
                //       other things).
                // 404 - Not found      - This is often used to find out if something exists.
                // 409 - Conflict       - Happens when we want to to do something with an item that hasn't been
                //                proppatched yet. Usually happens when we create a message, we have to
                //                proppacth it and then add attachments.
                // 505 - Server unavailable
                xml.LoadXml("<RESPONSE><ERROR><method>" + _HttpRequest.Method + "</method><MESSAGE>" + ex.Message + "</MESSAGE></ERROR></RESPONSE>");
            }
            return xml;
        }
        /// <SUMMARY>
        /// Adds range of rows to return
        /// </SUMMARY>
        /// <PARAM name="startRow">Start at row</PARAM>
        /// <PARAM name="endRow">End at row</PARAM>
        public void AddRange(int startRow, int endRow)
        {
            _HttpRequest.AddRange("rows", startRow, endRow);
        }
        #endregion
        */
    }
}
