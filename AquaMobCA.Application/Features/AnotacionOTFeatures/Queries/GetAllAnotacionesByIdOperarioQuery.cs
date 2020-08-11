using System;
using System.Collections.Generic;
using System.Text;
using Application.Wrappers;
using MediatR;

namespace Application.Features.AnotacionOTFeatures.Queries
{
    public class GetAllAnotacionesByIdOperarioQuery: IRequest<PagedResponse<IEnumerable<GetAllAnotacionesOTViewModel>>>
    {
    }
}
