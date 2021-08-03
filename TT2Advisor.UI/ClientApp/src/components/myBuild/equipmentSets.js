import { fn } from 'jquery';
import React, { Component, Fragment } from 'react';

export class EquipmentSets extends Component {

    equipmentSets: any;

    constructor(props) {
        super(props);
        this.state = { equipmentSets: this.props.equipmentSets, loading: true };
    }

    componentDidMount() {
        
    }

    render() {
        console.log(this.state.equipmentSets);
        return (
            <div>
                <h2>Equipment Sets</h2>
                <table className='table table-striped' aria-labelledby="tabelLabel">
                    <thead>
                        <tr>
                            <th>Equipment Set</th>
                            <th>Owned?</th>
                        </tr>
                    </thead>
                    <tbody>
                        {
                            Object.keys(this.state.equipmentSets).map((key, index) => {
                                //console.log({ k: key, v: this.state.equipmentSets[key], i: index });

                                let camelKey = key.replace(/(?:^\w|[A-Z]|\b\w)/g, function (word, index) {
                                    return index === 0 ? word.toLowerCase() : word.toUpperCase();
                                }).replace(/\s+/g, '');

                                return this.state.equipmentSets[key] && (
                                    <Fragment key={index}>
                                        <tr key={index}>
                                            <td>{this.state.equipmentSets[key].name}</td>
                                            <td>Yes</td>
                                        </tr>
                                        <tr key={"sword_" + index}>
                                            <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{this.state.equipmentSets[camelKey].sword.name}</td>
                                            <td>{this.state.equipmentSets[camelKey].sword.primaryDamageTypeFriendlyName}</td>
                                        </tr>
                                        <tr key={"helmet_" + index}>
                                            <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{this.state.equipmentSets[camelKey].helmet.name}</td>
                                            <td>{this.state.equipmentSets[camelKey].helmet.primaryDamageTypeFriendlyName}</td>
                                        </tr>
                                        <tr key={"armor_" + index}>
                                            <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{this.state.equipmentSets[camelKey].armor.name}</td>
                                            <td>{this.state.equipmentSets[camelKey].armor.primaryGoldSourceTypeFriendlyName}</td>
                                        </tr>
                                        <tr key={"aura_" + index}>
                                            <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{this.state.equipmentSets[camelKey].aura.name}</td>
                                            <td>{this.state.equipmentSets[camelKey].aura.primaryDamageTypeFriendlyName}</td>
                                        </tr>
                                        <tr key={"slash_" + index}>
                                            <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{this.state.equipmentSets[camelKey].slash.name}</td>
                                            <td>{this.state.equipmentSets[camelKey].slash.primaryDamageTypeFriendlyName}</td>
                                        </tr>
                                    </Fragment>
                                );
                            })
                        }
                    </tbody>
                </table>
            </div>
        );
    }

    //static camelize(str) {
    //    return str.replace(/(?:^\w|[A-Z]|\b\w)/g, function (word, index) {
    //        return index === 0 ? word.toLowerCase() : word.toUpperCase();
    //    }).replace(/\s+/g, '');
    //}
}
