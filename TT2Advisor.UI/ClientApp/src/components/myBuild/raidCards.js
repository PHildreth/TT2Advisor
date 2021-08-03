import React, { Component } from 'react';

export class RaidCards extends Component {

    raidCards: any;

    constructor(props) {
        super(props);
        this.state = { raidCards: this.props.raidCards, loading: true };
    }

    componentDidMount() {
        
    }

    render() {
        console.log(this.state.raidCards);
        return (
            <div>
                <h2>Raid Cards</h2>
                <table className='table table-striped' aria-labelledby="tabelLabel">
                    <thead>
                        <tr>
                            <th>Card</th>
                            <th>Level</th>
                        </tr>
                    </thead>
                    <tbody>
                        {
                            Object.keys(this.state.raidCards).map((key, index) => {
                                //console.log({ k: key, v: this.state.raidCards[key], i: index });
                                return (
                                    <tr key={index}>
                                        <td>{this.state.raidCards[key].friendlyName}</td>
                                        <td>{this.state.raidCards[key].level}</td>
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
