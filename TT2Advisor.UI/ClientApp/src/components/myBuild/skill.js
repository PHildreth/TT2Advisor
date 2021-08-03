import React, { Component } from 'react';

export class Skill extends Component {

    skill: any;

    constructor(props) {
        super(props);
        this.state = { skill: this.props.skill, loading: true };
    }

    componentDidMount() {

    }

    render() {
        return (
            <div>
                <table className='table table-striped' aria-labelledby="tabelLabel">
                    <thead>
                        <tr>
                            <th>{this.state.skill.friendlyName}</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <td>{this.state.skill.level}</td>
                        </tr>
                    </tbody>
                </table>
            </div>
        );
    }
}
