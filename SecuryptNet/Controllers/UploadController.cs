using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace SecuryptNet.Controllers {

    /// <summary>
    /// Controller to handle unencrypted files being uploaded to the application.
    /// <para>Author: Michael</para>
    /// Date: 2017-11-15
    /// <para>Based on: http://www.dotnetawesome.com/2017/02/drag-drop-file-upload-aspnet-mvc.html </para>
    /// </summary>
    public class UploadController : Controller {
        // GET: DragAndDrop
        public ActionResult Index() {
            return View("~/Views/Upload/Index.cshtml");
        }

        [HttpPost]
        public ActionResult UploadFiles(IEnumerable<HttpPostedFileBase> files) {
            var f = Request.Files[0];
            if(f == null) {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            foreach (var file in files) {
                string filePath = Guid.NewGuid() + Path.GetExtension(file.FileName);
                file.SaveAs(Path.Combine(Server.MapPath("~/UploadedFiles"), filePath));
                //Here you can write code for save this information in your database if you want
            }
            return Json("file uploaded successfully");
        }
    }
}