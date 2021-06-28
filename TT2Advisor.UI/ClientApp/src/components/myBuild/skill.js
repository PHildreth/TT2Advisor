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
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : Skill.renderSkill(this.state.skill);

        return (
            <div>
                <h2>Skill </h2>
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
