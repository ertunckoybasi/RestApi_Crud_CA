using Application.Features.GetAll;
using Application.Features.Products.Create;
using Application.Features.Products.Delete.Delete;
using Application.Features.Products.DeleteIfEmptyNames;
using Application.Features.Products.GetById;
using Application.Features.Products.Update;
using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RestApi_Crud_CA.WebAPI.Abstractions;

namespace RestApi_Crud_CA.WebAPI.Controllers
{
    [AllowAnonymous]
    public sealed class ProductController(IMediator mediator) : ApiController(mediator)
    {
        [HttpPost]
        public async Task<IActionResult> Create(CreateProductCommand request)
        {
            try
            {
                var result = await _mediator.Send(request);
                if (result.IsSuccess)
                {
                    return Ok();
                }
                else
                {
                    return BadRequest(result.Errors);
                }
            }
            catch (ValidationException ex)
            {
                return BadRequest(ex.Errors);
            }

        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateProductCommand request)
        {
            try
            {
                var result = await _mediator.Send(request);
                if (result.IsSuccess)
                {
                    return Ok();
                }
                else
                {
                    return BadRequest(result.Errors);
                }
            }
            catch (ValidationException ex)
            {
                return BadRequest(ex.Errors);
            }

        }

        [HttpDelete]
        public async Task<IActionResult> Delete(DeleteProductCommand request)
        {

            var result = await _mediator.Send(request);
            return result.IsSuccess ? Ok() : NotFound(result.Errors);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteIfNameEmpty(DeleteProductEmptyNamesCommand request)
        {
            var result = await _mediator.Send(request);
            return result.IsSuccess ? Ok() : NotFound(result.Errors);
        }



        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var request = new GetAllProductQuery();
            var result = await _mediator.Send(request);
            return Ok(result);

        }

        [HttpGet]
        public async Task<IActionResult> GetById(Guid productId)
        {
            try
            {
                var query = new GetProductByIdQuery(productId);
                var result = await _mediator.Send(query);
                return Ok(result);
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(new { message = ex.Message });
            }
        }
    }
}
