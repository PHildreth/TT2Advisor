import React, { Component } from 'react';

export class PassiveSkills extends Component {

    passiveSkills: any;

    constructor(props) {
        super(props);
        this.state = { passiveSkills: this.props.passiveSkills, loading: true };
    }

    componentDidMount() {
        
    }

    render() {
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : PassiveSkills.renderPassiveSkills(this.state.passiveSkills);

        return (
            <div>
                <h2>Passive Skills</h2>
                <table className='table table-striped' aria-labelledby="tabelLabel">
                    <thead>
                        <tr>
                            <th>Stat</th>
                            <th>Value</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <td>Intimidating Presence</td>
                            <td>{this.state.passiveSkills.intimidatingPresence}</td>
                        </tr>
                        <tr>
                            <td>Power Surge</td>
                            <td>{this.state.passiveSkills.powerSurge}</td>
                        </tr>
                        <tr>
                            <td>Anti-Titan Cannon</td>
                            <td>{this.state.passiveSkills.antiTitanCannon}</td>
                        </tr>
                        <tr>
                            <td>Mystical Impact</td>
                            <td>{this.state.passiveSkills.mysticalImpact}</td>
                        </tr>
                        <tr>
                            <td>Arcane Bargain</td>
                            <td>{this.state.passiveSkills.arcaneBargain}</td>
                        </tr>
                        <tr>
                            <td>Silent March</td>
                            <td>{this.state.passiveSkills.silentMarch}</td>
                        </tr>
                        <tr>
                            <td>Cloak And Dagger</td>
                            <td>{this.state.passiveSkills.cloakAndDagger}</td>
                        </tr>
                    </tbody>
                </table>
            </div>
        );
    }
}
