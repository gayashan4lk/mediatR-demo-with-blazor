using Core.Models;
using Core.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorUI.Application.Commands
{
    public record InsertPersonCommand(PersonViewModel PersonVM) : IRequest<Person>;

    //public class InsertPersonCommand : IRequest<Person>
    //{
    //    public PersonViewModel PersonVM { get; set; }

    //    public InsertPersonCommand(PersonViewModel personVM)
    //    {
    //        PersonVM = personVM;
    //    }
    //}
}
