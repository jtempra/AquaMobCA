using System;
using System.Collections.Generic;
using System.Text;
using Application.Wrappers;
using MediatR;

namespace Application.Features.AnotacionOTFeatures.Queries
{
    public class GetAllAnotacionesOTByIdOrdenTrabajoQuery: IRequest<PagedResponse<IEnumerable<GetAllAnotacionesOTViewModel>>>
    {
    }
}
