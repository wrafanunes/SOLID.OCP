using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    /*ao adicionar a propriedade IsManager, o OCP foi violado, pois uma classe existente foi modificada
     * O Princípio Aberto-Fechado (Open Closed Principle) deve ser estudado antes de ser colocado em prática no
     * projeto
     * enquanto o projeto estiver em desenvolvimento, as alterações podem ser feitas sem preocupações, mas após estar
     * em produção, mudanças só devem ser feitas para correção de bugs ou alterações de regras gerais
     * por ter sido uma mudança de pouca importância, a adição da propriedade IsManager é aceitável*/
    public class EmployeeModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public bool IsManager { get; set; }
        public bool IsExecutive { get; set; }
    }
}
