using System;
using System.Collections.Generic;
using System.Text;
using System.Web;

namespace YueDuLibrary.BLL
{

    public class tools
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fupAlbumCover">所选择的控件</param>
        /// <param name="fileType">1.图片，2.音频，3.视频，4.office文档,5.歌词</param>
        /// <param name="fileMAXLenth">最大文件</param>
        /// <returns></returns>
        public static string UploadFile(System.Web.UI.WebControls.FileUpload fupAlbumCover, int fileType, int fileMAXLenth)
        {
            string uploadFileName = "";


            if (fupAlbumCover.HasFile)
            {
                if (fupAlbumCover.FileContent.Length < fileMAXLenth * 1024 * 1024)
                {
                    string[] allowedExtension = { ".jpg", ".png", ".bmp", "jpeg", "gif" };
                    switch (fileType)
                    {
                        case 1: allowedExtension = new string[] { ".jpg", ".png", ".bmp", "jpeg", "gif" }; break;
                        case 2: allowedExtension = new string[] { ".mp3", ".wav", ".mid" }; break;
                        case 3: allowedExtension = new string[] { ".mp4", ".wmv", ".flv", "avi", "rmvb" }; break;
                        case 4: allowedExtension = new string[] { ".doc", ".docx", ".xls", "xlsx", "ppt", "pptx" }; break;
                        case 5: allowedExtension = new string[] { ".lrc" }; break;
                    }
                    string uploadedFileExtension = System.IO.Path.GetExtension(fupAlbumCover.FileName).ToLower();
                    bool isValid = false;
                    foreach (string fileExtension in allowedExtension)
                    {
                        if (uploadedFileExtension == fileExtension)
                        {
                            isValid = true;
                            break;
                        }
                    }
                    if (isValid)
                    {
                        Random r = new Random();
                        uploadFileName = DateTime.Now.ToString("yyyyMMddHHmmss") +
                            DateTime.Now.Millisecond.ToString() + r.Next(100).ToString() + uploadedFileExtension;
                        fupAlbumCover.SaveAs(HttpContext.Current.Server.MapPath("/UploadFiles/" + uploadFileName));

                    }
                    else
                    {

                        HttpContext.Current.Response.Write("<script>alert('请选择符合格式文件！')</script>");
                    }
                }
                else
                {

                    HttpContext.Current.Response.Write("<script>alert('该文件需小于" + fileMAXLenth + "MB！')</script>");
                }
            }
            else
            {
                HttpContext.Current.Response.Write("<script>alert('请选择一个文件！')</script>");
            }
            return uploadFileName;
        }

    }
}
