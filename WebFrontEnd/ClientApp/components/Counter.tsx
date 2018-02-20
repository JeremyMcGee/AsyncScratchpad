import * as React from 'react';
import { RouteComponentProps } from 'react-router';
import 'isomorphic-fetch';

interface CounterState {
    currentCount: number;
    delayStatus: string;
}

export class Counter extends React.Component<RouteComponentProps<{}>, CounterState> {
    constructor() {
        super();
        this.state = { currentCount: 0, delayStatus: "unknown" };
    }

    public render() {
        return <div>
            <h1>Counter</h1>

            <p>This is a simple example of a React component.</p>

            <p>Current count: <strong>{ this.state.currentCount }</strong></p>

            <button onClick={() => { this.incrementCounter() }}>Increment</button>

            <h2>Call Delay Service</h2>
            <p>This should call the Delay service.</p>
            <button onClick={() => { this.callDelayService() }}>Call Service</button>
            <p>Result: <strong>{ this.state.delayStatus }</strong></p>
        </div>;
    }

    incrementCounter() {
        this.setState({
            currentCount: this.state.currentCount + 1
        });
    }

    callDelayService() {
        this.setState({ delayStatus: "loading..." });
        fetch('api/SampleData/DelayService?duration=1000')
            .then(response => response.json() as Promise<DelayResult>)
            .then(data => {
                this.setState({ delayStatus: data.result });
            });
    }
}

interface DelayResult {
    result: string;
}
