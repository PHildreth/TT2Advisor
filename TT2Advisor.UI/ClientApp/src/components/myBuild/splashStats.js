import React, { Component } from 'react';

export class SplashStats extends Component {

    splashStats: any;

    constructor(props) {
        super(props);
        this.state = { splashStats: this.props.splashStats, loading: true };
    }

    componentDidMount() {
        
    }

    render() {
        console.log(this.state.splashStats);
        return (
            <div>
                <h2>Splash Stats</h2>
                <table className='table table-striped' aria-labelledby="tabelLabel">
                    <thead>
                        <tr>
                            <th>Stat</th>
                            <th>Value</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <td>Splash Damage</td>
                            <td>{this.state.splashStats.splashDamage}</td>
                        </tr>
                        <tr>
                            <td>Base Max Splash Count</td>
                            <td>{this.state.splashStats.baseMaxSplashCount}</td>
                        </tr>
                        <tr>
                            <td>All Splash Skip</td>
                            <td>{this.state.splashStats.allSplashSkip}</td>
                        </tr>
                        <tr>
                            <td>Heavenly Strike Splash Count</td>
                            <td>{this.state.splashStats.heavenlyStrikeSplashCount}</td>
                        </tr>
                        <tr>
                            <td>Lightning Burst Splash Count</td>
                            <td>{this.state.splashStats.lightningBurstSplashCount}</td>
                        </tr>
                        <tr>
                            <td>Clan Ship Splash Count</td>
                            <td>{this.state.splashStats.clanShipSplashCount}</td>
                        </tr>
                        <tr>
                            <td>Dagger Splash Count</td>
                            <td>{this.state.splashStats.daggerSplashCount}</td>
                        </tr>
                        <tr>
                            <td>Heavenly Strike Splash Skip</td>
                            <td>{this.state.splashStats.heavenlyStrikeSplashSkip}</td>
                        </tr>
                        <tr>
                            <td>Pet Splash Skip</td>
                            <td>{this.state.splashStats.petSplashSkip}</td>
                        </tr>
                        <tr>
                            <td>Clan Ship Splash Skip</td>
                            <td>{this.state.splashStats.clanShipSplashSkip}</td>
                        </tr>
                        <tr>
                            <td>Shadow Clone Splash Skip</td>
                            <td>{this.state.splashStats.shadowCloneSplashSkip}</td>
                        </tr>
                        <tr>
                            <td>Dagger Splash Skip</td>
                            <td>{this.state.splashStats.daggerSplashSkip}</td>
                        </tr>
                    </tbody>
                </table>
            </div>
        );
    }
}
