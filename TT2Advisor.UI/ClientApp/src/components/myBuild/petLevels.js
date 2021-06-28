import React, { Component } from 'react';

export class PetLevels extends Component {

    petLevels: any;

    constructor(props) {
        super(props);
        this.state = { petLevels: this.props.petLevels, loading: true };
    }

    componentDidMount() {

    }

    render() {
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : PetLevels.renderPetLevels(this.state.petLevels);

        return (
            <div>
                <h2>Pet Levels</h2>
                <table className='table table-striped' aria-labelledby="tabelLabel">
                    <thead>
                        <tr>
                            <th>Pet</th>
                            <th>Level</th>
                        </tr>
                    </thead>
                    <tbody>
                        {
                            Object.keys(this.state.petLevels).map((key, index) => {
                                console.log({ k: key, v: this.state.petLevels[key], i: index });
                                return (
                                    <tr key={index}>
                                        <td>{this.state.petLevels[key].name}</td>
                                        <td>{this.state.petLevels[key].level}</td>
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
