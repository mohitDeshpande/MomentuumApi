using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MomentuumApi.Model.CivicTrack;
using Microsoft.AspNetCore.Authorization;
using MomentuumApi.Utils;
using System.IO;
using Microsoft.AspNetCore.Http;

namespace MomentuumApi.Controllers
{
    [Produces("application/json")]
    [Route("api/File")]
    public class FileController : Controller
    {
        private readonly CivicTrackContext _context;

        public FileController(CivicTrackContext context)
        {
            _context = context;
        }

        // GET: api/File
        [HttpGet, Authorize]
        public IEnumerable<TblFiles> GetTblFiles()
        {
            return _context.TblFiles;
        }


        // GET: api/file/image{id}
        [Route("image/{id}")]
        [HttpGet, Authorize]
        public IActionResult GetImageFile([FromRoute] int? id)
        {


            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if (FileHelper.UseDB == true)
            {
                var file = _context.TblFileStore.Where(i => i.Id.Equals(id)).SingleOrDefault();

                if (file == null)
                {
                    return NotFound();
                }


                else
                {
                    try
                    {

                        Byte[] imgBytes = file.File;

                        if (imgBytes != null)
                        {
                            MemoryStream ms = new MemoryStream(imgBytes);
                            return new FileStreamResult(ms, file.FileType);
                        }



                    }
                    catch (Exception ex)
                    {

                        return NotFound();
                    }

                }
            }
            else
            {
                var file = _context.TblFiles.Where(i => i.Id.Equals(id)).SingleOrDefault();


                if (file == null)
                {
                    return NotFound();
                }


                else
                {
                    try
                    {
                        var image = System.IO.File.OpenRead(FileHelper.BasePath + file.FileName);
                        return File(image, "image/jpeg");
                    }
                    catch (Exception ex)
                    {
                        return NotFound();
                    }

                }
            }

            return NotFound();

        }

        // GET: api/File/5
        [HttpGet("{id}"), Authorize]
        public async Task<IActionResult> GetTblFiles([FromRoute] int? id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var tblFiles = await _context.TblFiles.SingleOrDefaultAsync(m => m.Id == id);

            if (tblFiles == null)
            {
                return NotFound();
            }

            return Ok(tblFiles);
        }

        // PUT: api/File/5
        [HttpPut("{id}"), Authorize]
        public async Task<IActionResult> PutTblFiles([FromRoute] int? id, [FromBody] TblFiles tblFiles)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tblFiles.Id)
            {
                return BadRequest();
            }

            _context.Entry(tblFiles).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TblFilesExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        //Post: api/File/Store
        [Route("store")]
        [HttpPost, Authorize]
        public async Task<IActionResult> StoreFile( [FromForm] TblFileStore file)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            
           
            if ( file!=null)
            {
               
                if (FileHelper.UseDB == true)
                {
                   
                    try
                    {
                        if (file.FileUpload != null)
                        {
                            MemoryStream ms = new MemoryStream();
                            file.FileUpload.CopyTo(ms);
                            Byte[] imgBytes = ms.ToArray();
                            file.File = imgBytes;
                        }
                                              
                        file.Deleted = "false";
                        file.FileType = file.FileUpload.ContentType;
                        _context.TblFileStore.Add(file);
                        await _context.SaveChangesAsync();
                        return Ok();
                        //return CreatedAtRoute("Id", new { id = fs.Id });
                    }
                  
                    catch (Exception ex)
                    {
                        throw;
                    }

                   
                }
                return NoContent();
            }
            
            else
            {
                //Implement if File system is being used 
                return NoContent();
            }
        }

        // POST: api/File
        [HttpPost, Authorize]
        public async Task<IActionResult> PostTblFiles([FromBody] TblFileStore file)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if (FileHelper.UseDB == true)
            {
                file.Deleted = "false";
                _context.TblFileStore.Add(file);
                await _context.SaveChangesAsync();

                return CreatedAtRoute("GetTblFiles", new { id = file.Id }, file);
            }
            else
            {
                TblFiles tblFile = new TblFiles();
                if (String.IsNullOrWhiteSpace(file.CaseItemId)) { tblFile.CaseItemId = file.CaseItemId; }
                if(String.IsNullOrWhiteSpace(file.Comments)) { tblFile.Comments = file.Comments; }
                if (String.IsNullOrWhiteSpace(file.Deleted)) { tblFile.Deleted="false"; }
                if (String.IsNullOrWhiteSpace(file.FileName)) { tblFile.FileName = file.FileName; }
                if (String.IsNullOrWhiteSpace(file.VoterId)){ tblFile.VoterId = file.VoterId; }
                if (String.IsNullOrWhiteSpace(file.Riding)) { tblFile.Riding = file.Riding; }
                if (String.IsNullOrWhiteSpace(file.UserId)) { tblFile.UserId = file.UserId; }
                _context.TblFileStore.Add(file);
                await _context.SaveChangesAsync();

                return CreatedAtRoute("GetTblFiles", new { id = file.Id }, file);
            }

            
        }

        // DELETE: api/File/5
        [HttpDelete("{id}"), Authorize]
        public async Task<IActionResult> DeleteTblFiles([FromRoute] int? id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var tblFiles = await _context.TblFiles.SingleOrDefaultAsync(m => m.Id == id);
            if (tblFiles == null)
            {
                return NotFound();
            }

            _context.TblFiles.Remove(tblFiles);
            await _context.SaveChangesAsync();

            return Ok(tblFiles);
        }

        private bool TblFilesExists(int? id)
        {
            return _context.TblFiles.Any(e => e.Id == id);
        }
        private bool TblFileStoreExists(int? id)
        {
            return _context.TblFileStore.Any(e => e.Id == id);
        }
    }
}