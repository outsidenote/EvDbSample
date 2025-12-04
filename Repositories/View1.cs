namespace Abstractions;
using EvDb.Core;
using Abstractions;

[EvDbViewType<State1, IEventsSet>("view_1")]
public partial class View1
{
    protected override State1 DefaultState { get; } = new State1(0);
    protected override State1 Apply(State1 state, Event1 payload, IEvDbEventMeta meta)
    {
        return state  with 
            {sum = state.sum + payload.value1};
    }

    protected override State1 Apply(State1 state, Event2 payload, IEvDbEventMeta meta)
    {
        return state with
            {sum = state.sum + payload.value2};
    }
}