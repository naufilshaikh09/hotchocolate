using HotChocolate.Configuration;
using HotChocolate.Utilities;
using HotChocolate.Types;

namespace HotChocolate.Data.Filters.Expressions
{
    public class QueryableEnumInHandler
        : QueryableComparableInHandler
    {
        public QueryableEnumInHandler(
            ITypeConverter typeConverter,
            InputParser inputParser)
            : base(typeConverter, inputParser)
        {
        }

        public override bool CanHandle(
            ITypeCompletionContext context,
            IFilterInputTypeDefinition typeDefinition,
            IFilterFieldDefinition fieldDefinition)
        {
            return context.Type is IEnumOperationFilterInputType &&
                fieldDefinition is FilterOperationFieldDefinition operationField &&
                operationField.Id == Operation;
        }
    }
}
