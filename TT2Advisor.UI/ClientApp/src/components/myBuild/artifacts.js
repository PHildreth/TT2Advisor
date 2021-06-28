import React, { Component } from 'react';

export class Artifacts extends Component {

    artifacts: any;

    constructor(props) {
        super(props);
        this.state = { artifacts: this.props.artifacts, loading: true };
    }

    componentDidMount() {

    }

    render() {
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : Artifacts.renderArtifacts(this.state.artifacts);

        return (
            <div>
                <h2>Artifacts</h2>
                <table className='table table-striped' aria-labelledby="tabelLabel">
                    <thead>
                        <tr>
                            <th>Artifact</th>
                            <th>Level</th>
                        </tr>
                    </thead>
                    <tbody>
                        {
                            Object.keys(this.state.artifacts).map((key, index) => {
                                console.log({ k: key, v: this.state.artifacts[key], i: index });
                                return (
                                    <tr key={index}>
                                        <td>{this.state.artifacts[key].friendlyName}</td>
                                        <td>{this.state.artifacts[key].level}</td>
                                    </tr>
                                );
                            })
                        }
                    </tbody>
                </table>
            </div>
        );
    }
}
