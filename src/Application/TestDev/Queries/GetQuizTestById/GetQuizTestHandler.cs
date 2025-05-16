using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _Net6CleanArchitectureQuizzApp.Application.Common.Interfaces;
using _Net6CleanArchitectureQuizzApp.Application.Common.Models;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using static System.Collections.Specialized.BitVector32;

namespace _Net6CleanArchitectureQuizzApp.Application.TestDev.Queries.GetQuizTestById;
public record GetQuizTestQuery : IRequest<Result<QuizTestDto>>
{
    //Query that will be sent , parameters
    public int Id { get; set; } 

}
public class GetQuizTestHandler : IRequestHandler<GetQuizTestQuery,Result<QuizTestDto>>
{
    private readonly IApplicationDbContext _context;
    private readonly IMapper _mapper;

    public GetQuizTestHandler(IApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<Result<QuizTestDto>> Handle(GetQuizTestQuery request, CancellationToken cancellationToken)
    {
        var Test = await _context.Tests.FirstOrDefaultAsync(x => x.Id == request.Id);
        if(Test == null)
        {
            return Result<QuizTestDto>.Failure("Session not found");
        }

        var dto = _mapper.Map<QuizTestDto>(Test);
        return Result<QuizTestDto>.Success(dto);

    }
}

