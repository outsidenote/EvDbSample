namespace Abstractions;
using EvDb.Core;

[EvDbDefineEventPayload("Event1")]
public partial record Event1(int value1)
{
}