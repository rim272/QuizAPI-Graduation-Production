﻿using _Net6CleanArchitectureQuizzApp.Application.Common.Exceptions;
using _Net6CleanArchitectureQuizzApp.Application.Common.Interfaces;
using _Net6CleanArchitectureQuizzApp.Domain.Entities;
using MediatR;

namespace _Net6CleanArchitectureQuizzApp.Application.TodoItems.Commands.UpdateTodoItem;

//public record UpdateTodoItemCommand : IRequest
//{
//    public int Id { get; init; }

//    public string? Title { get; init; }

//    public bool Done { get; init; }
//}

//public class UpdateTodoItemCommandHandler : IRequestHandler<UpdateTodoItemCommand>
//{
//    private readonly IApplicationDbContext _context;

//    public UpdateTodoItemCommandHandler(IApplicationDbContext context)
//    {
//        _context = context;
//    }

//    public async Task<Unit> Handle(UpdateTodoItemCommand request, CancellationToken cancellationToken)
//    {
//        var entity = await _context.TodoItems
//            .FindAsync(new object[] { request.Id }, cancellationToken);

//        if (entity == null)
//        {
//            throw new NotFoundException(nameof(TodoItem), request.Id);
//        }

//        entity.Title = request.Title;
//        entity.Done = request.Done;

//        await _context.SaveChangesAsync(cancellationToken);

//        return Unit.Value;
//    }
//}
